using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // interface için I harfi ile başlatabilir .
    interface IKrediManager
    {
        // imza aynı ama içerisi farklı o yüzden interface 
        void Hesapla();
        void BiseyYap();
    }
}
