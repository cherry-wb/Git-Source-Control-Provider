﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitScc
{
    public class GitBranchInfo
    {
        private const string REMOTE_FULL_NAME = "remotes/{0}/{1}";

        public string Name { get; set; }
        public string FullName {
            get
            {
                return IsRemote ? string.Format(REMOTE_FULL_NAME, RemoteName, Name) : Name;
            }
        }
        public bool IsRemote { get; set; }
        public string RemoteName { get; set; }
        /// <summary>
        /// Gets the full name of this reference.
        /// 
        /// </summary>
        public string CanonicalName { get; set; }
        public bool IsCurrentRepoHead { get; set; }

        /// <summary>
        /// Gets the 40 character sha1 of this object.
        /// 
        /// </summary>
        public string Sha { get; set; }

    }
}
