// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections;
using System.Threading;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Tests
{
    public static class ThreadStressHelper
    {
        public static void ThreadStress(ThreadStart testMethod, int threadCount)
        {
            ArrayList threads = new ArrayList();
            for (int i = 0; i < threadCount; i++)
            {
                threads.Add(new Thread(testMethod));
            }

            foreach (Thread thread in threads)
            {
                thread.Start();
            }
            foreach (Thread thread in threads)
            {
                thread.Join();
            }
        }
    }
}


