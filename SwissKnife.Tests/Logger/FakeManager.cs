using System;

namespace SwissKnife.Tests.Logger
{
    class FakeManager
    {
        public void Do()
        {
            try
            {
                Op1();
            }
            catch (InvalidOperationException ex)
            {
                throw new ApplicationException("app exception", ex);
            }
            catch (DivideByZeroException ex)
            {
                throw new ApplicationException("app exception", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("app exception", ex);
            }
        }

        private void Op1()
        {
            Op2();
        }

        private void Op2()
        {
            try
            {
                Op3();
            }
            catch (DivideByZeroException dbzex)
            {
                throw new InvalidOperationException("Invalid operation", dbzex);
            }
        }

        private void Op3()
        {
            int n = 0;
            int x = 3 / n;
        }
    }

}
