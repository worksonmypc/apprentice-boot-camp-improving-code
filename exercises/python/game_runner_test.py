import unittest
from golden_master import GoldenMaster
from trivia import run
from io import StringIO
import sys

class GameRunnerTest(unittest.TestCase):
        
    def test_golden_master(self):
        original_out = sys.stdout
        for i in range(0, 10000):
            out_content = StringIO()
            sys.stdout = out_content

            run(i)
            self.assertEqual(str(out_content.getvalue()), GoldenMaster().get_result(i))
        sys.stdout = original_out


if __name__ == '__main__':
    unittest.main()
