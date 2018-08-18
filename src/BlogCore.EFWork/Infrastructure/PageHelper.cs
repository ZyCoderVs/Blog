using System;
using System.Collections.Generic;

namespace BlogCore.EFWork.Infrastructure
{
    public class PageHelper
    {
        public static List<string> GetPageList(int currentIndex, int total, int disPage)
        {
            List<string> pageList = new List<string>();
            if (disPage > total)
            {
                for (int i = 1; i <= total; i++)
                {
                    pageList.Add(i.ToString());
                }
                return pageList;
            }

            for (int i = 1; i <= disPage; i++)
            {
                if (i < 3)
                {
                    pageList.Add(i.ToString());
                }
                else if (i == 3)
                {
                    if (currentIndex > 5)
                    {
                        pageList.Add("0");
                    }
                    else
                    {
                        pageList.Add(i.ToString());
                    }
                }
                else if (i < (disPage - 1))
                {
                    if (currentIndex >= 5)
                    {
                        if ((currentIndex + (i - 4)) >= total)
                        {
                            continue;
                        }
                        pageList.Add((currentIndex + (i - 5)).ToString());
                    }
                    else
                    {
                        pageList.Add(i.ToString());
                    }
                }
                else if (i == (disPage - 1))
                {
                    if (total - currentIndex > 2)
                    {
                        pageList.Add("0");
                    }
                    else
                    {
                        pageList.Add((total - 1).ToString());
                    }
                }
                else
                {
                    pageList.Add(total.ToString());
                }
            }

            return pageList;
        }
    }
}
