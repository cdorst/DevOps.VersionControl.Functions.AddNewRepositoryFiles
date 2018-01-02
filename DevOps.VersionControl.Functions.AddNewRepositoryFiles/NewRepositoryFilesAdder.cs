using DevOps.VersionControl.Structures.GitCommitUser;
using static DevOps.VersionControl.Functions.AddAndCommitGitAttributesIgnoreFiles.GitAttirubtesIgnoreFilesCommitter;
using static DevOps.VersionControl.Functions.AddAndCommitGnuGpl3License.GnuGpl3LicenseCommitter;
using static Metaproject.Users.CDorst.GitCommit.Users;

namespace DevOps.VersionControl.Functions.AddNewRepositoryFiles
{
    public static class NewRepositoryFilesAdder
    {
        public static void AddAndCommitNewRepositoryFiles(string repositoryDirectory, UserInfo? user = null)
            => AddFiles(repositoryDirectory, user ?? CDorst);

        private static void AddFiles(string path, UserInfo user)
        {
            AddAndCommitLicense(path, user);
            AddAndCommitGitAttributeIgnoreFiles(path, user);
        }
    }
}
