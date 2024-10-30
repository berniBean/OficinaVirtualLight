namespace WindowsFormsApp6.CAD.DAL.factories
{
    public class factoryURL
    {
        public const int RIF = 1;
        public const int PLUS = 2;
        public const int MRIF = 3;
        public const int MPLUS = 4;

        public static obtenerURL maker(int tipo)
        {
            switch (tipo)
            {
                case RIF:
                    return new CUrlDAL(1);
                case PLUS:
                    return new CUrlDAL(3);
                case MRIF:
                    return new CUrlDAL(2);
                case MPLUS:
                    return new CUrlDAL(4);
                default:
                    return null;
            }
        }

    }
}
