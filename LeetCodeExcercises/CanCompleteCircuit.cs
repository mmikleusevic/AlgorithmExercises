namespace LeetCodeExcercises
{
    public static class CanCompleteCircuit
    {
        public static int CanCompleteCircuitMethod(int[] gas, int[] cost)
        {
            int totalGas = 0;
            int currentTank = 0;
            var startIndex = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                totalGas += gas[i] - cost[i];
                currentTank += gas[i] - cost[i];
                if (currentTank < 0)
                {
                    startIndex = i + 1;
                    currentTank = 0;
                }
            }
            return totalGas >= 0 ? startIndex : -1;
        }
    }
}
