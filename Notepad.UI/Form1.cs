using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notepad.Entities;
using Notepad.Business.Concrete;
using System.IO;
using Notepad.Entities.Concrete;

namespace Notepad.UI
{
    public partial class Form1 : Form
    {
        private FileManager _fileManager = new FileManager(); // FileManager sınıfından bir örnek oluşturur.
        private Note _currentNote = new Note(); // Şu anki not nesnesini tutar.
        private bool _isTextChanged = false; // Metin değişip değişmediğini kontrol eder.
        public Form1()
        {
            InitializeComponent();
            // Metin veya imleç değiştiğinde caret konumunu güncelle
            Rtbx.TextChanged += (s, ev) => UpdateStatusBar(); // Yazı yazma
            // Sadece mouse hareketindeyken fare konumunu gönder
            Rtbx.MouseMove += (s, ev) => UpdateStatusBar(ev.Location);

            this.FormClosing += Form1_FormClosing; // Form kapanırken CheckForChanges metodunu çağırır.

        }

        private void Rtbx_TextChanged(object sender, EventArgs e)
        {
            int charindex = Rtbx.SelectionStart; // Seçili metnin başlangıç konumunu alır.
            _isTextChanged = true; // Metin değiştiğinde bu değişkeni true yapar.
            UpdateStatusBar(); // Durum çubuğunu günceller.
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckForChanges(e); // Form kapanmadan önce değişiklikleri kontrol eder.
        }

        private void UpdateStatusBar(Point? mouselocation = null)
        {
            int charindex = mouselocation.HasValue ?
                Rtbx.GetCharIndexFromPosition(mouselocation.Value)
                : Rtbx.SelectionStart; // Fare konumu varsa onu alır, yoksa seçili metnin başlangıç konumunu alır.

            // Durum çubuğundaki satır, sütun ve kelime sayısını günceller.
            int lineCount = Rtbx.GetLineFromCharIndex(charindex); // Satır sayısını alır.
            int linestart = Rtbx.GetFirstCharIndexFromLine(lineCount);
            int columnCount = Math.Max(0, charindex - linestart); // Sütun sayısını alır.
            if (charindex < 0 || lineCount < 0 || linestart < 0)
            {
                columnCount = 0;
            }

            int wordCount = Rtbx.Text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length; // Kelime sayısını alır.

            DisplayStatusBar(lineCount, columnCount,wordCount);
        }

        private void DisplayStatusBar(int lineCount, int columnCount, int wordCount)
        {
            //Eğer textbox boşsa, kelime sayısını sıfırlar.
            if (string.IsNullOrEmpty(Rtbx.Text))
            {
                wordCount = 0;
                lineCount = 0;
                columnCount = 0;
            }

            // Durum çubuğundaki etiketleri günceller.
            LineSsl.Text = "Satır: " + (lineCount + 1).ToString(); // Satır sayısını günceller.
            CoulmnSsl.Text = "Sütun: " + (columnCount).ToString(); // Sütun sayısını günceller.
            WordSsl.Text = "Kelime: " + (wordCount).ToString();    // Kelime sayısını günceller.
        }

        private bool CheckForChanges(FormClosingEventArgs e = null)
        {
            if (_isTextChanged)
            {
                DialogResult result = MessageBox.Show("Değişiklikleri kaydetmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Save_Tsmi_Click(this, null);
                    return true;
                }
                else if (result == DialogResult.Cancel)
                {
                    if (e != null)
                        e.Cancel = true;
                    return false; // Cancel pressed
                }
                // No pressed, continue
            }
            return true; // No changes or not canceled
        }


        private void New_Tsmi_Click(object sender, EventArgs e)
        {
            if (!CheckForChanges()) return;// Yeni not oluşturulmadan önce değişiklikleri kontrol eder.
            _currentNote = new Note(); // Yeni bir not nesnesi oluşturur.
            Rtbx.Clear(); // RichTextBox içeriğini temizler.
            this.Text = "Notepad - Yeni Not"; // Form başlığını günceller.
            _isTextChanged = false; // Metin değişmediğini belirtir.

        }

        private void Save_Tsmi_Click(object sender, EventArgs e)
        {
            // Not nesnesini oluşturur ve içeriğini alır.
            if (string.IsNullOrEmpty(_currentNote.FilePath))
            {
                // Dosya yolu yoksa kullanıcıdan dosya yolunu alır.

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                // Dosya kaydetme penceresini açar.
                
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                // Dosya kaydetme penceresinin başlığını ayarlar.

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _currentNote.FilePath = saveFileDialog.FileName; // Dosya yolunu alır.
                }
                // Eğer kullanıcı dosya yolunu seçmediyse işlemi iptal eder.
                else
                {
                    return;
                }
                _currentNote.Content = Rtbx.Text; // RichTextBox içeriğini alır.
                _fileManager.Save(_currentNote); // Notu dosyaya kaydeder.
                this.Text = "Notepad - " + Path.GetFileName(_currentNote.FilePath); // Form başlığını günceller.
                _isTextChanged = false; // Metin değişmediğini belirtir.

            }

        }

        private void Open_Tsmi_Click(object sender, EventArgs e)
        {
            if (!CheckForChanges()) return;// Dosya açılmadan önce değişiklikleri kontrol eder.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Dosya açma penceresini açar.
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // Dosya açma penceresinin başlığını ayarlar.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _currentNote = _fileManager.Load(openFileDialog.FileName); // Dosyadan notu yükler.
                Rtbx.Text = _currentNote.Content; // RichTextBox içeriğini günceller.
                this.Text = "Notepad - " + Path.GetFileName(_currentNote.FilePath); // Form başlığını günceller.
                _isTextChanged = false; // Metin değişmediğini belirtir.
            }

        }

        private void Undo_Tsmi_Click(object sender, EventArgs e)
        {
            // Geri alma işlemi için RichTextBox kontrolünü kullanır.
            if (Rtbx.CanUndo)
            {
                Rtbx.Undo(); // Geri alma işlemini yapar.
            }
            Rtbx_TextChanged(this, null); // Metin değiştiğini belirtir.

        }

        private void Redo_Tsmi_Click(object sender, EventArgs e)
        {
            // İleri alma işlemi için RichTextBox kontrolünü kullanır.
            if (Rtbx.CanRedo)
            {
                Rtbx.Redo(); // İleri alma işlemini yapar.
            }
            Rtbx_TextChanged(this, null); // Metin değiştiğini belirtir.

        }

        private void Cut_Tsmi_Click(object sender, EventArgs e)
        {
            //Kesme işlemi için RichTextBox kontrolünü kullanır.
            if (Rtbx.SelectionLength > 0)
            {
                Rtbx.Cut(); // Seçili metni keser ve panoya kopyalar.
            }
            Rtbx_TextChanged(this, null); // Metin değiştiğini belirtir.


        }

        private void Copy_Tsmi_Click(object sender, EventArgs e)
        {
            // Kopyalama işlemi için RichTextBox kontrolünü kullanır.
            if (Rtbx.SelectionLength > 0)
            {
                Rtbx.Copy(); // Seçili metni panoya kopyalar.
            }
            Rtbx_TextChanged(this, null); // Metin değiştiğini belirtir.

        }

        private void Paste_Tsmi_Click(object sender, EventArgs e)
        {
            // Yapıştırma işlemi için RichTextBox kontrolünü kullanır.
            if (Clipboard.ContainsText())
            {
                Rtbx.Paste(); // Panodaki metni yapıştırır.
            }
            Rtbx_TextChanged(this, null); // Metin değiştiğini belirtir.

        }

        private void Delete_Tsmi_Click(object sender, EventArgs e)
        {
            // Silme işlemi için RichTextBox kontrolünü kullanır.
            if (Rtbx.SelectionLength > 0)
            {
                Rtbx.SelectedText = ""; // Seçili metni siler.
            }
            Rtbx_TextChanged(this, null); // Metin değiştiğini belirtir.

        }

        private void Rtbx_MouseMove(object sender, MouseEventArgs e)
        {
            // Fare konumunu alır.
            // Fare hareket ettiğinde durum çubuğunu günceller.
            UpdateStatusBar(e.Location);

        }
    }
}
