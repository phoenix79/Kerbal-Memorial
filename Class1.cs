using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kerbal_Memorial
{
    class CrewMember
    {
        String KerbalName;
        int KerbalState;
        bool BadS;

        public CrewMember(String KerbalName, int KerbalState, bool BadS)
        {
            this.KerbalName = KerbalName;
            this.KerbalState = KerbalState;
            this.BadS = BadS;
        }
    }
}
