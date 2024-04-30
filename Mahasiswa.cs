namespace modul10_1302220078
{
    public class Mahasiswa
    {
        public String name{ get; set; }
        public String nim { get; set; }
        public List<string> course { get; set; }
        public int year { get; set; }
        public Mahasiswa(String nama, String nim, List<string> course, int year)
        {
            this.name = nama;
            this.nim = nim;
            this.course = course;
            this.year = year;
        }
    }
}
