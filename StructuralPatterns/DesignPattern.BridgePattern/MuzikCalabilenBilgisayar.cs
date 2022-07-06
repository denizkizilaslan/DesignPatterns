using DesignPattern.BridgePattern.Bridge;
using DesignPattern.BridgePattern.Models.Abstract;

namespace DesignPattern.BridgePattern
{
    public abstract class MuzikCalabilenBilgisayar
    {
        protected ISesCihazi sesCihazi;
        protected IMuzikCalar muzikCalar;

        public MuzikCalabilenBilgisayar()
        {

        }
        public MuzikCalabilenBilgisayar(ISesCihazi sesCihazi, IMuzikCalar muzikCalar)
        {
            this.sesCihazi = sesCihazi;
            this.muzikCalar = muzikCalar;
        }

        public void MuzikCal(Muzik muzik)
        {
            muzikCalar.MuzikCal(muzik);
        }

    }
}
