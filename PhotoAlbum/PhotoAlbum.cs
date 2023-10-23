using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album {
    class PhotoAlbum {
        private int numberOfPages;

        public int GetNumberOfPages() {
            return numberOfPages;
        }
        public PhotoAlbum() {
            numberOfPages = 16;
        }
        public PhotoAlbum(int numberOfPages) {
            this.numberOfPages = numberOfPages;
        }
    }
    class BigPhotoAlbum {
        private int numberOfPages;
        public BigPhotoAlbum() {
            numberOfPages = 64;
        }
        public int GetNumberOfPages() {
            return numberOfPages;
        }
    }
}
