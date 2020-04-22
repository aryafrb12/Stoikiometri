using System;
using System.Collections.Generic;
using System.Text;

namespace Stoikiometri
{
    class Molalitas
    {
        internal float massap, mols;

        public float Massap
        {
            get { return massap; }
            set { massap = value; }
        }

        public float Mols
        {
            get { return mols; }
            set { mols = value; }
        }

        public float YMolalitas()
        {
            float molal = mols / massap;
            return molal;
        }
    }
}
