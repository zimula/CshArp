using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public interface IFlyStrategy
    {
        void DoFly();
    }
    public interface IQuackStrategy
    {
        void DoQuack();
    }
    public interface ISwimStrategy
    {
        void DoSwim();
    }
    public interface IGoobleStrategy
    {
        void DoGooble();
    }
}
