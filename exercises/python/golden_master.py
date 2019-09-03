import sys
import trivia
import traceback
import sys
from io import StringIO

class GoldenMaster:
    def __init__(self):
        self.out_content = StringIO()
        self.original_out = sys.stdout


    def get_result(self, i):
        result = None
        try:
            result = open('./resources/output%d.txt', 'r')

        except IOError:
            result = self.generate_expected_result(i)

        return result


    def generate_expected_result(self, i):
        result = None
        sys.stdout = self.out_content 

        trivia.run(i)

        file_name = './resources/output%d.txt' % i
        with open(file_name, 'w') as master:
            result = self.out_content.getvalue()
            master.write(result)

            sys.stdout = self.original_out
            self.out_content.close()

        return result
