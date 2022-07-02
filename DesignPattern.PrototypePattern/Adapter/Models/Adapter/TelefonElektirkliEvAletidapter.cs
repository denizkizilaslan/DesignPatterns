using Adapter.Models.Abstract;

namespace Adapter.Models.Adapter
{
    class TelefonElektirkliEvAletidapter : IElektrikliEvAletleri
    {
        private ITelefon telefon;
        public TelefonElektirkliEvAletidapter(ITelefon telefon)
        {
            this.telefon = telefon;
        }

        public int prizeTakVeCalistir()
        {
            return telefon.sarjEt();
        }
    }
}
