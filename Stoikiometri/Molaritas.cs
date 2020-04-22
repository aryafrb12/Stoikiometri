using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace Stoikiometri
{
    class Molaritas
    {
        internal float mol, volume, massa, mr, tvolume;

        public float Mol
        {
            get { return mol; }
            set { mol = value; }
        }

        public float Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public float YMolaritas()
        {
            float ymolar = mol / volume;
            return ymolar;
        }

        public float Massa
        {
            get { return massa; }
            set { massa = value; }
        }

        public float Mr
        {
            get { return mr; }
            set { mr = value; }
        }

        public float TVolume
        {
            get { return tvolume; }
            set { tvolume = value; }
        }

        public float TMol()
        {
            float hmol = massa / mr;
            return hmol;
        }

        public float TMolaritas()
        {
            float tmol = TMol() / tvolume;
            return tmol;
        }
    }
}
