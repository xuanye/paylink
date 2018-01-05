﻿using System;
using System.IO;

using Essensoft.AspNetCore.Security.Utilities.IO;

namespace Essensoft.AspNetCore.Security.Crypto.Tls
{
    internal class SignerInputBuffer
        : MemoryStream
    {
        internal void UpdateSigner(ISigner s)
        {
            Streams.WriteBufTo(this, new SigStream(s));
        }

        private class SigStream
            : BaseOutputStream
        {
            private readonly ISigner s;

            internal SigStream(ISigner s)
            {
                this.s = s;
            }

            public override void WriteByte(byte b)
            {
                s.Update(b);
            }

            public override void Write(byte[] buf, int off, int len)
            {
                s.BlockUpdate(buf, off, len);
            }
        }
    }
}
