namespace WindowsFormsApp6.CAD.BO
{
    public class pdfSQL
    {
        public pdfSQL(string numReq, string numCtrl, string estatusPDF, string rutaFTP)
        {
            this.numReq = numReq;
            this.numCtrl = numCtrl;
            this.estatusPDF = estatusPDF;
            this.rutaFTP = rutaFTP;
        }
        public pdfSQL(string numCtrl, string estatusPDF)
        {
            this.numCtrl = numCtrl;
            this.estatusPDF = estatusPDF;
        }

        public string numReq { get; set; }
        public string numCtrl { get; set; }
        public string estatusPDF { get; set; }
        public string rutaFTP { get; set; }

    }
}
