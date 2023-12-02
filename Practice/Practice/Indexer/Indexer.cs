namespace Practice.Indexer
{
    public class Indexer
    {
        private int[] ip = new int[4];

        public int this[int index]
        {
            get
            {
                return ip[index];
            }
            set
            {
                ip[index] = value;
            }
        }
        //public Indexer(int seg1,int seg2,int seg3, int seg4)
        //{
        //    ip[0] = seg1;
        //    ip[1] = seg2;
        //    ip[2] = seg3;
        //    ip[3] = seg4;
        //}
        public string GetIP => string.Join(".", ip);
    }
}
