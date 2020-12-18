using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Class containing methods pertaining to matrices.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Class containing an operation.
        /// </summary>
        public static int Max(List<int> nums)
        {
            nums.Sort();
            return (nums[nums.Count - 1]);
    
            catch (ArgumentOutOfRangeException)
            {
                return 0;
            }


        }
    }
}
