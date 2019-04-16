import sys
from timeit import default_timer as timer

# For 1:1 mappings
leetDict1 = {
  'a': ['@'],
  'B': ['8'],
  'c': ['('],
  'e': ['3'],
  'G': ['6'],
  'i': ['1'],
  'I': ['1'],
  'l': ['1'],
  'o': ['0'],
  'O': ['0'],
  's': ['$'],
  'S': ['$'],
  't': ['7'],
  'T': ['7'],
  'x': ['%'],
  'X': ['%'],
  'z': ['2'],
  'Z': ['2']
}

# For 1:n mappings
leetDict = {
  'a': ['4', '@'],
  'B': ['8'],
  'c': ['('],
  'e': ['3'],
  'G': ['6'],
  'i': ['1'],
  'I': ['1'],
  'l': ['1'],
  'o': ['0'],
  'O': ['0'],
  's': ['5', '$'],
  'S': ['5', '$'],
  't': ['7'],
  'T': ['7'],
  'x': ['%'],
  'X': ['%'],
  'z': ['2'],
  'Z': ['2']
}

# Permute function for Complexity Level 1
def permute1(dictWord):
  if len(dictWord) > 0:
    currentLetter = dictWord[0]
    restOfWord = dictWord[1:]

    if currentLetter in leetDict1:
      substitutions = leetDict1[currentLetter] + [currentLetter]
    else:
      substitutions = [currentLetter]

    if len(restOfWord) > 0:
      perms = [s + p for s in substitutions for p in permute1(restOfWord)]
    else:
      perms = substitutions
    return perms

# Permute function for Complexity Level 2
def permute2(dictWord):
  repeatLetters = []
  perms = [dictWord]
  if len(dictWord) > 0:

    for letter in dictWord:
      if letter in repeatLetters:
        continue
      elif letter in leetDict:
        perms = perms + [p.replace(letter, r) for r in leetDict[letter] for p in perms]

    return list(set(perms))

# Permute function for Complexity Level 3
def permute3(dictWord):
  if len(dictWord) > 0:
    currentLetter = dictWord[0]
    restOfWord = dictWord[1:]

    if currentLetter in leetDict:
      substitutions = leetDict[currentLetter] + [currentLetter]
    else:
      substitutions = [currentLetter]

    if len(restOfWord) > 0:
      perms = [s + p for s in substitutions for p in permute3(restOfWord)]
    else:
      perms = substitutions
    return perms


def makeDict(complexityLevel):
  
  print "Begin Timing.."
  print "Working.."
  start_time = timer()

  # Open and read password file ; Open output file
  infile = open(sys.argv[1], 'r')
  wordList = infile.read().splitlines()
  infile.close()
  outfile = open('leetDict.txt', 'w+')


  # Switch block
  if complexityLevel == '1':
    for word in wordList:
      outfile.writelines([p + '\n' for p in permute1(word)])
  elif complexityLevel == '2':
    for word in wordList:
      outfile.writelines([p + '\n' for p in permute2(word)])
  elif complexityLevel == '3':
    for word in wordList:
      outfile.writelines([p + '\n' for p in permute3(word)])
  else:
    print 'Invalid input, please select from the provided options'
    return

  outfile.close()
  end_time = timer()
  elapsed_time = end_time - start_time
  print 'Done.\nTime elapsed: ', elapsed_time

  return elapsed_time


# For runtime analysis
# sum = 0
# for x in range(1000):
#   sum += makeDict()

# print "Average runtime:", sum / 1000


# User input for complexity level
print 'Please select your desired list complexity:\n1. 1:1 mapping\n2. 1:n consistent mapping\n3. 1:n permutable mapping'
level = raw_input()
makeDict(level)