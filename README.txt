# YouCanGoYourOwnWay
Code Jam Question 1

For more details visit:
https://codingcompetitions.withgoogle.com/codejam/round/0000000000051705/00000000000881da

----------------------------------------------------------------------------------------------------------------------------------------

Input
The first line of the input gives the number of test cases, T. T test cases follow; each case consists of two lines. The first line contains one integer N, giving the dimensions of the maze, as described above. The second line contains a string P of 2N - 2 characters, each of which is either uppercase E (for east) or uppercase S (for south), representing Lydia's valid path through the maze.

Output
For each test case, output one line containing Case #x: y, where x is the test case number (starting from 1) and y is a string of 2N - 2 characters each of which is either uppercase E (for east) or uppercase S (for south), representing your valid path through the maze that does not conflict with Lydia's path, as described above. It is guaranteed that at least one answer exists.

Limits
1 ≤ T ≤ 100.
Time limit: 15 seconds per test set.
Memory limit: 1GB.
P contains exactly N - 1 E characters and exactly N - 1 S characters.

Test set 1 (Visible)
2 ≤ N ≤ 10.

Test set 2 (Visible)
2 ≤ N ≤ 1000.

Test set 3 (Hidden)
For at most 10 cases, 2 ≤ N ≤ 50000.
For all other cases, 2 ≤ N ≤ 10000.

Sample

Input
 	
Output
 
2
2
SE
5
EESSSESE

  
Case #1: ES
Case #2: SEEESSES

  
In Sample Case #1, the maze is so small that there is only one valid solution left for us.

Sample Case #2 corresponds to the picture above. Notice that it is acceptable for the paths to cross.
