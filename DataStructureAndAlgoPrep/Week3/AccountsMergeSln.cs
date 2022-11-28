using System;
using System.Collections.Generic;

namespace DataStructureAndAlgoPrep.Week3
{
    public class AccountsMergeSln
    {
        private readonly IDictionary<string, IList<string>> adjacencyGraph = new Dictionary<string, IList<string>>();
        private readonly ISet<string> visited = new HashSet<string>();

        public void DepthFirstSearch(IList<string> mergedAccount, string currentEmail)
        {
            visited.Add(currentEmail);

            mergedAccount.Add(currentEmail);

            if (!this.adjacencyGraph.ContainsKey(currentEmail)) return;

            foreach (string neighborEmail in this.adjacencyGraph[currentEmail])
            {
                if (!this.visited.Contains(neighborEmail))
                {
                    DepthFirstSearch(mergedAccount, neighborEmail);
                }
            }
        }

        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            List<IList<string>> mergedAccounts = new List<IList<string>>();

            foreach (IList<string> account in accounts)
            {
                string firstEmail = account[1];

                for (int i = 2; i < account.Count; ++i)
                {
                    string nextEmail = account[i];

                    if (!this.adjacencyGraph.ContainsKey(firstEmail))
                    {
                        this.adjacencyGraph.Add(firstEmail, new List<string>());
                    }

                    this.adjacencyGraph[firstEmail].Add(nextEmail);

                    if (!this.adjacencyGraph.ContainsKey(nextEmail))
                    {
                        this.adjacencyGraph.Add(nextEmail, new List<string>());
                    }

                    this.adjacencyGraph[nextEmail].Add(firstEmail);
                }
            }

            foreach (IList<string> account in accounts)
            {
                string nameOfTheAccountHolder = account[0];
                string firstEmailOfTheAccount = account[1];

                if (this.visited.Contains(firstEmailOfTheAccount))
                {
                    continue;
                }

                List<string> mergedAccount = new List<string>();
                mergedAccount.Add(nameOfTheAccountHolder);
                DepthFirstSearch(mergedAccount, firstEmailOfTheAccount);
                mergedAccount.Sort(index: 1, count: mergedAccount.Count - 1, comparer: null);

                mergedAccounts.Add(mergedAccount);
            }

            return mergedAccounts;
        }
    }
}
