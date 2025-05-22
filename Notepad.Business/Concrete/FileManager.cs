using Notepad.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notepad.Entities;
using Notepad.DataAccess;
using Notepad.Entities.Concrete;


namespace Notepad.Business.Concrete
{
    // IFileService arayüzünü uygulayan FileManager sınıfı
    // Dosya işlemleri için gerekli olan metotları içerir.

    public class FileManager : IFileService
    {
        private NoteDal _noteDal = new NoteDal(); // Veri erişim katmanındaki NoteDal sınıfını kullanır.
        public Note Load(string filepath)
        {
            return _noteDal.LoadFromFile(filepath); // Dosyadan notu yükle

        }

        public void Save(Note note)
        {
            note.CreatedDate = DateTime.Now; // Notun oluşturulma tarihini güncelle
            _noteDal.SavetoFile(note); // Notu dosyaya kaydet
        }
    }
}
