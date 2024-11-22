namespace BowlingGame
{
    public class BowlingGame
    {
        public static int CalculateScore(string game)
        {
            var totalScore = 0; // Total score for the game
            var frameIndex = 0; // Current frame being processed
            
            if (string.IsNullOrEmpty(game)) return totalScore; // Handle empty input
            
            var frames = game.Split('|', StringSplitOptions.RemoveEmptyEntries); // Split into frames

            // Process the first 10 frames
            for (var i = 0; i < 10; i++)
            {
                var frame = frames[frameIndex];

                if (frame == "X") // Strike
                {
                    totalScore += 10 + GetStrikeBonus(frames, frameIndex);
                    frameIndex++;
                }
                else if (frame.Contains('/')) // Spare
                {
                    totalScore += 10 + GetSpareBonus(frames, frameIndex);
                    frameIndex++;
                }
                else // Open Frame
                {
                    totalScore += GetOpenFrameScore(frame);
                    frameIndex++;
                }
            }

            return totalScore;
        }

        private static int GetStrikeBonus(string[] frames, int currentIndex)
        {
            int bonus = 0, ballsCounted = 0;

            for (var i = currentIndex + 1; i < frames.Length && ballsCounted < 2; i++)
            {
                foreach (var c in frames[i])
                {
                    if (ballsCounted >= 2) break;

                    switch (c)
                    {
                        case 'X': bonus += 10; ballsCounted++; break;
                        case '-': ballsCounted++; break;
                        case '/': bonus = 10; ballsCounted++; break;
                        default: if (char.IsDigit(c)) { bonus += int.Parse(c.ToString()); ballsCounted++; } break;
                    }
                }
            }

            return bonus;
        }

        private static int GetSpareBonus(string[] frames, int currentIndex)
        {
            var nextIndex = currentIndex + 1;
            if (nextIndex >= frames.Length) return 0;

            var nextFrame = frames[nextIndex];
            if (nextFrame.Length <= 0) return 0;
            var firstRoll = nextFrame[0];
            return firstRoll switch
            {
                'X' => 10,
                '-' => 0,
                _ => char.IsDigit(firstRoll) ? int.Parse(firstRoll.ToString()) : 0
            };
        }

        private static int GetOpenFrameScore(string frame)
        {
            var score = 0;
            for (var i = 0; i < frame.Length; i++)
            {
                var c = frame[i];
                switch (c)
                {
                    case '-':
                        score += 0;
                        break;
                    case '/':
                        score += 10 - int.Parse(frame[i - 1].ToString());
                        break;
                    default:
                    {
                        if (char.IsDigit(c)) score += int.Parse(c.ToString());
                        break;
                    }
                }
            }
            return score;
        }
     }

}
