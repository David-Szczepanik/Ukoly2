using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album {
    internal class AlbumTest {
        static void Main(string[] args) {

            PhotoAlbum a1 = new PhotoAlbum();
            PhotoAlbum a2 = new PhotoAlbum(24);
            BigPhotoAlbum ba1 = new BigPhotoAlbum();

            Console.WriteLine("Album 1 has " + a1.GetNumberOfPages() + " pages.");
            Console.WriteLine("Album 2 has " + a2.GetNumberOfPages() + " pages.");
            Console.WriteLine("Big Album has " + ba1.GetNumberOfPages() + " pages.");
        }
    }
}
