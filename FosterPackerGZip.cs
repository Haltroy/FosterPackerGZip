/*

Copyright © 2021 - 2022 haltroy

Use of this source code is governed by a MIT License that can be found in github.com/haltroy/Foster/blob/master/COPYING

*/

using System.IO;

namespace LibFoster.Modules
{
    /// <summary>
    /// Packing class with Delta creation and application with GZip compression.
    /// </summary>
    public class FosterPackerGZip : FosterPackerBase
    {
        public override string PackerName => "gzip";

        public override Stream GenerateCompressStream(Stream inStream) => new System.IO.Compression.GZipStream(inStream, System.IO.Compression.CompressionMode.Compress, true);

        public override Stream GenerateDecompressStream(Stream inStream) => new System.IO.Compression.GZipStream(inStream, System.IO.Compression.CompressionMode.Decompress, true);
    }
}