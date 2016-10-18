using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventureTest
{
    class CommandParser
    {
        public CommandParser(string command)
        {
            string lowerCommand = command.ToLower();
            string[] commandElements = lowerCommand.Split(' ');
            switch (commandElements[0])
            {
                case "go":
                    {
                        switch (commandElements[1])
                        {
                            case "north":
                                {
                                    //code to move north
                                    break;
                                }
                            case "south":
                                {
                                    //code to move south
                                    break;
                                }
                            case "west":
                                {
                                    //code to move west
                                    break;
                                }
                            case "east":
                                {
                                    //code to move east
                                    break;
                                }
                            default:
                                {
                                    
                                    break;
                                }

                        }
                    break;
                    }
            }



        }
    }
}
