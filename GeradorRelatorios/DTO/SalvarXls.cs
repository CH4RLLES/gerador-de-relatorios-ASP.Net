using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorRelatorios.DTO
{
    public class SalvarXls : IDisposable
    {
        private byte[] Bytes;
        private IList<Stream> m_streams;

        public string PageWidth { get; set; }
        public string PageHeight { get; set; }
        public string MarginTop { get; set; }
        public string MarginLeft { get; set; }
        public string MarginRight { get; set; }
        public string MarginBottom { get; set; }

        public void Dispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                {
                    stream.Close();
                    stream.Dispose();
                }
                m_streams = null;
            }
        }

        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public void Export(LocalReport report, string caminho)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            string deviceInfo =
                  $@"<DeviceInfo>
                        <OutputFormat>EXCELOPENXML</OutputFormat>
                        <PageWidth>{PageWidth}</PageWidth>
                        <PageHeight>{PageHeight}</PageHeight>
                        <MarginTop>{MarginTop}</MarginTop>
                        <MarginLeft>{MarginLeft}</MarginLeft>
                        <MarginRight>{MarginRight}</MarginRight>
                        <MarginBottom>{MarginBottom}</MarginBottom>
                    </DeviceInfo>";

            Bytes = report.Render("EXCELOPENXML", deviceInfo, PageCountMode.Actual, out mimeType, out encoding, out extension, out streamids, out warnings);

            var fs = new FileStream(caminho, FileMode.Create);
            fs.Write(Bytes, 0, Bytes.Length);
        }
    }
}
