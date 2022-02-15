using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Block
    {
        public int x;
        public int y;
    }
    public class Level
    {
        public string Name;
        public string Song;
        public int Speed;
        public int NextLevel;
        public IList<Block> Blocks;
    }
    class LevelsRoot
    {
        public IList<Level> Levels;
    }

}
