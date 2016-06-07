﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH_simulator
{
    public static class ECDH_brainpoolP160r1
    {
        /*
            p is the prime specifying the base field.

            A and B are the coefficients of the equation y^2 = x^3 + A*x + B mod p defining the elliptic curve.

            G = (x,y) is the base point, i.e., a point in E of prime order, with x and y being its x- and y-coordinates, respectively.

            q is the prime order of the group generated by G.

            h is the cofactor of G in E, i.e., #E(GF(p))/q.

        */

        public const string p_hex = "E95E4A5F737059DC60DFC7AD95B3D8139515620F";

        public const string A_hex = "340E7BE2A280EB74E2BE61BADA745D97E8F7C300";

        public const string B_hex = "1E589A8595423412134FAA2DBDEC95C8D8675E58";

        public const string x_hex = "BED5AF16EA3F6A4F62938C4631EB5AF7BDBCDBC3";

        public const string y_hex = "1667CB477A1A8EC338F94741669C976316DA6321";

        public const string q_hex = "E95E4A5F737059DC60DF5991D45029409E60FC09";

        public const string h_hex = "1";
    }
}