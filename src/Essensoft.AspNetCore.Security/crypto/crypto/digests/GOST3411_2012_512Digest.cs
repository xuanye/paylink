﻿using System;
using Essensoft.AspNetCore.Security.Utilities;

namespace Essensoft.AspNetCore.Security.Crypto.Digests
{
    public class GOST3411_2012_512Digest:GOST3411_2012Digest
    {
		private readonly static byte[] IV = {
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
	};

		public override string AlgorithmName
		{
			get { return "GOST3411-2012-512"; }
		}

        public GOST3411_2012_512Digest():base(IV)
        {
        }

		public GOST3411_2012_512Digest(GOST3411_2012_512Digest other) : base(IV)
		{
            Reset(other);
        }

        public override int GetDigestSize()
        {
            return 64;
        }

		public override IMemoable Copy()
		{
			return new GOST3411_2012_512Digest(this);
		}
    }
}
