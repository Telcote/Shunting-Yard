using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace model_lab1
{
    public class DijkstraPostfix
    {
        // Таблица приоритетов операций
        private static Dictionary<byte, byte> priorityDict = new Dictionary<byte, byte>()
        {
            { 0, 0 }, { 1, 0 }, { 2, 1 }, { 3, 1 },
            { 4, 3 }, { 5,  3 }, { 6, 4 }, { 7, 4},
            { 8, 4 }, { 9, 4 }, { 10,  4 }, { 11, 4}
        };

        private List<byte> input = new List<byte>();

        public void AddToList(byte b)
        {
            input.Add(b);
            //При изменении входной строки обновляем Enumerator
            pos = input.GetEnumerator();
        }

        public void RemoveLastItem()
        {
            input.RemoveAt(input.Count - 1);
        }
        public void ClearInputStack() { input.Clear(); }

        public List<byte> GetInputString() { return input; }



        public List<byte> output = new List<byte>();
        
        public List<byte> GetOutputString() { return output; }



        private Stack<byte> stack = new Stack<byte>();

        public List<byte> GetStack() { return stack.ToList(); }

        public void ClearAll()
        {
            stack.Clear();
            input.Clear();
            output.Clear();
        }

        //Состояние 0 означает начальное состояние
        public byte state = 0;
        public bool fail = false;

        private void Fail()
        {
            this.fail = true;
            this.state = 0;
        }

        private List<byte>.Enumerator pos;

        public void Tick()
        {
            if(input.Count > 0)
            {
                //Если не дошли до дна массива
                if ( pos.MoveNext() )
                {
                    this.fail = false;
                    byte b = pos.Current;
                    switch (b)
                    {
                        // a b c d
                        case 12: case 13: case 14: case 15:
                            {
                                output.Add(b);
                                break;
                            }
                        case 0:
                            {
                                stack.Push(b);
                                break;
                            }
                        case 1:
                            {
                                while ( stack.Count > 0 && stack.Peek() != 0)
                                { 
                                    output.Add(stack.Pop());

                                    //Если стек пустой, то пропущена скобка

                                    if (stack.Count == 0)
                                    {
                                        Fail();
                                        break;
                                    }
                                }
                                
                                stack.Pop();
                                break;
                            }
                        // - + * / ln cos sin ^ tg sqrt
                        case 2: case 3: case 4: case 5:
                        case 6: case 7: case 8: case 9:
                        case 10: case 11:
                            {
                                while (stack.Count > 0 && priorityDict[stack.Peek()] >= priorityDict[b])
                                {
                                    output.Add(stack.Pop());
                                }
                                stack.Push(b);
                                break;
                            }
                    } 
                    
                } 
                else
                {
                    while (stack.Count > 0 && this.fail != true)
                    {
                        output.Add(stack.Pop());
                    }
                    this.state = 0;
                }

            }
            else
            {
                Fail();
            }
        }
    }
}
