using System.IO;
using System.Runtime.InteropServices; // Marshal
using System.Windows.Media;
using System.Windows.Media.Imaging; // GIF

namespace GameOfLife
{
    public static class GifCreator
    {

        private static Dictionary<System.Drawing.Imaging.PixelFormat, System.Windows.Media.PixelFormat> Formats;
        public static void AddFormats()
        {
            // Dictionary anlegen
            Formats = new Dictionary<System.Drawing.Imaging.PixelFormat, System.Windows.Media.PixelFormat> {

                // Dictionary und befüllen
                { System.Drawing.Imaging.PixelFormat.Format32bppArgb, PixelFormats.Pbgra32 },
                { System.Drawing.Imaging.PixelFormat.Format24bppRgb, PixelFormats.Bgr24 }
            };
        }

        public static bool Save(List<Bitmap> bmps, string path)
        {
            //Check the formats
            if (Formats == null || Formats.Count == 0) {
                AddFormats();
            }

            //No images?
            if (bmps.Count == 0) {
                return false;
            }

            bmps.Reverse();
            //to get the right direction


            //Encoder
            var encoder = new GifBitmapEncoder();

            //Add all bmps

            foreach (var bmp in bmps) {
                //Known Format?
                if (!Formats.ContainsKey(bmp.PixelFormat)) {
                    return false;
                }

                //Get the bmpdata
                var rc = new Rectangle(0, 0, bmp.Width, bmp.Height);
                System.Drawing.Imaging.BitmapData bmpData = null;
                bmpData = bmp.LockBits(rc, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);

                byte[] pixels = new byte[rc.Height * bmpData.Stride];

                Marshal.Copy(bmpData.Scan0, pixels, 0, pixels.Length);
                bmp.UnlockBits(bmpData);


                //Add to the gif
                var bmpsrc = BitmapSource.Create(rc.Width, rc.Height, 96, 96, Formats[bmp.PixelFormat], null, pixels, bmpData.Stride);
                encoder.Frames.Add(BitmapFrame.Create(bmpsrc));
            }



            //Safe gif
            using (var fstream = new FileStream(path, FileMode.CreateNew)) {
                encoder.Save(fstream);
            }

            return true;
        }

    }

}
