using System;

namespace Singleton
{
    public class ChocoPdfs : IEquatable<ChocoPdfs>
    {
        public ChocoPdfs(string name, string fullName)
        {
            _name = name;
            _fullName = fullName;
        }
        public ChocoPdfs()
        {

        }
        public ChocoPdfs(string name)
        {
            _name = name;
        }
        public string _name { get; set; }
        public string _fullName { get; set; }

        public string _numDocto { get; set; }

        public bool Equals(ChocoPdfs other)
        {
            if (_name == other._name)
                return true;
            else
                return false;
        }
    }
}
