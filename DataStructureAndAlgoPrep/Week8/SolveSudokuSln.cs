using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week8;

public class SolveSudokuSln
{
    private bool solved = false;
    private char[][] board;
    private IList<ISet<int>> rows = new List<ISet<int>>();
    private IList<ISet<int>> cols = new List<ISet<int>>();
    private IList<ISet<int>> boxes = new List<ISet<int>>();


    public void SolveSudoku(char[][] board)
    {
        this.board = board;

        for (int i = 0; i < 9; ++i)
        {
            this.rows.Add(new HashSet<int>());
            this.cols.Add(new HashSet<int>());
            this.boxes.Add(new HashSet<int>());
        }

        for (int i = 0; i < 9; ++i)
        {
            for (int j = 0; j < 9; ++j)
            {
                if (this.board[i][j] != '.')
                {
                    int num = this.board[i][j] - '0';
                    this.rows[i].Add(num);
                    this.cols[j].Add(num);

                    int box_id = (i / 3) * 3 + j / 3;

                    this.boxes[box_id].Add(num);
                }
            }
        }


        Backtrack(0, 0);
    }

    public void Backtrack(int i, int j)
    {
        int new_i = i;

        if (j == 8)
        {
            new_i = new_i+1;
        }

        int new_j = (j + 1) % 9;

        if (i == 9)
        {
            this.solved = true;
            return;
        }


        if (this.board[i][j] != '.')
        {
            Backtrack(new_i, new_j);
        }
        else
        {
            for (int d = 0; d < 9; ++d)
            {
                int box_id = (i / 3) * 3 + j / 3;

                if (!this.rows[i].Contains(d)
                && !this.cols[j].Contains(d)
                && !this.boxes[box_id].Contains(d))
                {
                    this.rows[i].Add(d);
                    this.cols[j].Add(d);
                    this.boxes[box_id].Add(d);
                    this.board[i][j] = (char)((int)'0' + d);

                    Backtrack(new_i, new_j);

                    if (!this.solved)
                    {
                        this.board[i][j] = '.';
                        this.rows[i].Remove(d);
                        this.cols[j].Remove(d);
                        this.boxes[box_id].Remove(d);
                    }
                }
            }
        }
    }
}
