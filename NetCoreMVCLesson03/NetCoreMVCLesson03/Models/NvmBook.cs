namespace NetCoreMVCLesson03.Models
{
    public class NvmBook
    {
        public int NvmId { get; set; }
        public string NvmTitle { get; set; }
        public string NvmDescription { get; set; }
        public string NvmImages { get; set; }
        public float NvmPrice { get; set; }
        public int NvmPage { get; set; }
       

        // Hàm tĩnh để trả danh sách sách mẫu
        public static List<Book> GetBookList()
        {
            return new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "Chí Phèo",
                    AuthorId = 1,
                    GenreId = 1,
                    Images = "/images/products/CHIPHEO.jfif",
                    Price = 500000,
                    Sumary = "Tác phẩm của Nam Cao",
                    TotalPage = 250
                },
                new Book
                {
                    Id = 2,
                    Title = "Lão Hạc",
                    AuthorId = 1,
                    GenreId = 2,
                    Images = "/images/products/LAOHAC.jfif",
                    Price = 300000,
                    Sumary = "Một câu chuyện cảm động",
                    TotalPage = 180
                },
                new Book
                {
                    Id = 3,
                    Title = "Tắt Đèn",
                    AuthorId = 2,
                    GenreId = 1,
                    Images = "/images/products/TATDEN.jfif",
                    Price = 450000,
                    Sumary = "Ngô Tất Tố viết về nông dân",
                    TotalPage = 220
                },
                new Book
                {
                    Id = 4,
                    Title = "Số Đỏ",
                    AuthorId = 3,
                    GenreId = 3,
                    Images = "/images/products/SODO.jfif",
                    Price = 550000,
                    Sumary = "Tác phẩm trào phúng",
                    TotalPage = 260
                }
            };
        }
    }
}

