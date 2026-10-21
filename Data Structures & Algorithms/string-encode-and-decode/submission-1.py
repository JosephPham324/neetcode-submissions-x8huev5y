class Solution:
    delimiter = "#"
    def encode(self, strs: List[str]) -> str:
        res = ""
        for string in strs:
            # encode each string as
            # 4string#
            # length + string + delimiter
            res += self.delimiter + f"{len(string):03d}" + string
        return res
        

    def decode(self, s: str) -> List[str]:
        res = []

        while len(s) != 0:
            length = int(s[1:4])
            string = s[4:4 + length]
            res.append(string)
            s = s[4 + length:]

        return res

        
