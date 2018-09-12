// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Reflection;
using System.Security.Permissions;
using System.Threading;

namespace Microsoft.Practices.EnterpriseLibrary.Common.TestSupport
{
    public class CrossThreadTestRunner
    {
        private ThreadStart userDelegate;
        private Exception lastException;

        public CrossThreadTestRunner(ThreadStart userDelegate)
        {
            this.userDelegate = userDelegate;
        }

        public void Run()
        {
            Thread t = new Thread(new ThreadStart(this.MultiThreadedWorker));

            t.Start();
            t.Join();

            if (lastException != null)
            {
                ThrowExceptionPreservingStack(lastException);
            }
        }

        [ReflectionPermission(SecurityAction.Demand)]
        private static void ThrowExceptionPreservingStack(Exception exception)
        {
            FieldInfo remoteStackTraceString = typeof(Exception).GetField("_remoteStackTraceString", BindingFlags.Instance | BindingFlags.NonPublic);
            remoteStackTraceString.SetValue(exception, exception.StackTrace + Environment.NewLine);
            throw exception;
        }

        private void MultiThreadedWorker()
        {
            try
            {
                userDelegate.Invoke();
            }
            catch (Exception e)
            {
                lastException = e;
            }
        }
    }
}


