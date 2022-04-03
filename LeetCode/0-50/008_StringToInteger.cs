using static System.Char;

namespace LeetCode._0_50
{
    public class _008_StringToInteger
    {
        public int MyAtoi(string s)
        {
            return new AtoiStateMachine(s).Handle();
        }

        private class AtoiStateMachine
        {
            private string _s;

            private int _stringIndex;

            private State _state;

            private int _sign = 1;

            private int _result = 0;

            public AtoiStateMachine(string s)
            {
                _s = s;
            }

            public int Handle()
            {
                while (_state != State.Processed)
                {
                    if (_stringIndex == _s.Length)
                    {
                        _state = State.Processed;
                    }

                    switch (_state)
                    {
                        case State.WhitespaceProcessing:
                        {
                            if (_s[_stringIndex] == ' ')
                            {
                                _stringIndex++;
                            }
                            else
                            {
                                if (IsDigit(_s[_stringIndex]))
                                {
                                    _state = State.DigitProcessing;
                                }
                                else
                                {
                                    if (_s[_stringIndex] == '+' || _s[_stringIndex] == '-')
                                    {
                                        _state = State.SignProcessing;
                                    }
                                    else
                                    {
                                        _state = State.Processed;
                                    }
                                }
                            }

                            break;
                        }
                        case State.SignProcessing:
                        {
                            if (_s[_stringIndex] == '-')
                            {
                                _sign = -1;
                            }

                            _state = State.DigitProcessing;
                            _stringIndex++;
                            break;
                        }
                        case State.DigitProcessing:
                        {
                            if (IsDigit(_s[_stringIndex]))
                            {
                                AddToResult(_s[_stringIndex] - '0');
                                _stringIndex++;
                            }
                            else
                            {
                                _state = State.Processed;
                            }

                            break;
                        }
                    }
                }

                return (_sign * _result);
            }

            private void AddToResult(int value)
            {
                int resultWithSign = _sign * _result;
                if (resultWithSign > int.MaxValue / 10 || (resultWithSign == int.MaxValue / 10 && value > 7))
                {
                    _result = int.MaxValue;
                    return;
                }

                if (resultWithSign < int.MinValue / 10 || (resultWithSign == int.MinValue / 10 && value > 8))
                {
                    _sign = 1;
                    _result = int.MinValue;
                    return;
                }

                _result = _result * 10 + value;
            }

            private enum State
            {
                WhitespaceProcessing,
                SignProcessing,
                DigitProcessing,
                Processed,
            }
        }
    }
}
