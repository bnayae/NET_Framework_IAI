using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamsAndDecorators
{
    /// <summary>
    /// A stream that automatically dispatches output requests (writes) to multiple
    /// other streams, enabling a composite-like abstraction of a stream.
    /// Each of the operations in this class override an abstract method or property
    /// of the Stream class and implement it with regard to multiple output destinations.
    /// Read-related operations and the Seek operation are not supported.
    /// </summary>
    public class CompositeOutputStream : Stream
    {
        private readonly Stream[] _streams;

        public CompositeOutputStream(params Stream[] streams)
        {
            _streams = streams;
        }

        public override void Close()
        {
            foreach (var s in _streams)
            {
                s.Close();
            }
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            foreach (var s in _streams)
            {
                s.Write(buffer, offset, count);
            }
        }

        public override void Flush()
        {
            foreach (var s in _streams)
            {
                s.Flush();
            }
        }

        public override long Position
        {
            get
            {
                return _streams.First().Position;
            }
            set
            {
                Array.ForEach(_streams, s => s.Position = value);
            }
        }

        public override void SetLength(long value)
        {
            Array.ForEach(_streams, s => s.SetLength(value));
        }

        public override bool CanRead
        {
            get { return false; }
        }

        public override bool CanSeek
        {
            get { return false; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override long Length
        {
            get { return (from s in _streams select s.Length).Max(); }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        protected override void Dispose(bool disposing)
        {
            //Array.ForEach(_streams, s => s.Dispose());
        }
    }
}
