using System;

namespace avanceredemetoder_overload
{
    class Program
    {
        static void Main(string[] args)
        {
byte a = 8;
Nibble n1 = new Nibble(a);
Console.WriteLine(n1.Value);

int b = 8;
Nibble n2 = new Nibble(b);
Console.WriteLine(n2.Value);

string c = "1000";
Nibble n3 = new Nibble(c);
Console.WriteLine(n3.Value);

Nibble n4 = new Nibble("0000");
n4 = a;
n4 = b;
n4 = c;
Console.WriteLine(n4.Value);

byte d = n4;
Console.WriteLine(d);
int e = n4;
Console.WriteLine(e);
string f = n4;
Console.WriteLine(f);

Nibble n5 = new Nibble(8);
Nibble n6 = new Nibble(9);
Console.WriteLine(n5 > n6);
Console.WriteLine(n5 < n6);
Console.WriteLine(n5 == n6);
Console.WriteLine(n5 != n6);

        }
    }

    internal class Nibble
    {
        private byte value; // byte er 256, nibbel er 16
        
        public byte Value {
            get {
                return value;
            }
        }

        public Nibble(byte value)
        {
            CheckVærdi(value);
            this.value = value;
        }

        public Nibble(int value)
        {
            CheckVærdi(value);
            this.value = Convert.ToByte(value);
        }

        public Nibble(string value)
        {
            byte v = Convert.ToByte(value, 2);
            CheckVærdi(v);
            this.value = v;
        }

        public static implicit operator string(Nibble n)
        {
            return Convert.ToString(n.value, 2);
        }

        public static implicit operator int(Nibble n)
        {
            return n.value;
        }

        public static implicit operator byte(Nibble n)
        {
            return n.value;
        }

        public static implicit operator Nibble(byte v)
        {
            CheckVærdi(v);
            return new Nibble(v);
        }
        public static implicit operator Nibble(int v)
        {
            CheckVærdi(v);
            return new Nibble(v);
        }
        public static implicit operator Nibble(string s)
        {
            byte v = Convert.ToByte(s, 2);
            CheckVærdi(v);
            return new Nibble(v);
        }
        public static bool operator >(Nibble p1, Nibble p2)
        {
            return p1.value > p2.value;
        }

        public static bool operator <(Nibble p1, Nibble p2)
        {
            return p1.value < p2.value;
        }

        public static bool operator ==(Nibble p1, Nibble p2)
            => (p1.value == p2.value);

        public static bool operator !=(Nibble p1, Nibble p2)
            => !(p1.value == p2.value);

        public override bool Equals(object obj)
        {
            return obj is Nibble nibble &&
                   value == nibble.value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value);
        }

        private static void CheckVærdi(int v) {
            if (v > 15 || v < 0)
                throw new Exception("Forkert værdi");
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
