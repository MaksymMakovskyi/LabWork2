namespace LabWork2._1
{
    internal class SecondName
    {
        string f;
        int v;
        int o;
        int p1;
        int p2;
        //Конструктор
        public SecondName(string f, int v, int o)
        {
            this.f = f;
            this.v = v;
            this.o = o;
            p1 = v - o;
            p2 = p1 * 100 / v;
        }
        public string F
        {
            get { return f; }
            set { f = value; }
        }
        public int V
        {
            get { return v; }
            set { v = value; }
        }
        public int O
        {
            get { return o; }
            set { o = value; }
        }
        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }
        public int P2
        {
            get { return p2; }
            set { p2 = value; }
        }
    }
}
