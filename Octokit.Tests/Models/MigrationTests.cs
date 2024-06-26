﻿using System.Collections.Generic;
using Octokit.Internal;
using Xunit;

namespace Octokit.Tests.Models
{
    public class MigrationTests
    {
        const string migrationJson = @"
            {
              ""id"": 79,
              ""guid"": ""0b989ba4-242f-11e5-81e1-c7b6966d2516"",
              ""state"": ""pending"",
              ""lock_repositories"": true,
              ""exclude_attachments"": false,
              ""url"": ""https://api.github.com/orgs/octo-org/migrations/79"",
              ""created_at"": ""2015-07-06T15:33:38-07:00"",
              ""updated_at"": ""2015-07-06T15:33:38-07:00"",
              ""repositories"": [
                {
                  ""id"": 1296269,
                  ""owner"": {
                    ""login"": ""octocat"",
                    ""id"": 1,
                    ""avatar_url"": ""https://github.com/images/error/octocat_happy.gif"",
                    ""gravatar_id"": """",
                    ""url"": ""https://api.github.com/users/octocat"",
                    ""html_url"": ""https://github.com/octocat"",
                    ""followers_url"": ""https://api.github.com/users/octocat/followers"",
                    ""following_url"": ""https://api.github.com/users/octocat/following{/other_user}"",
                    ""gists_url"": ""https://api.github.com/users/octocat/gists{/gist_id}"",
                    ""starred_url"": ""https://api.github.com/users/octocat/starred{/owner}{/repo}"",
                    ""subscriptions_url"": ""https://api.github.com/users/octocat/subscriptions"",
                    ""organizations_url"": ""https://api.github.com/users/octocat/orgs"",
                    ""repos_url"": ""https://api.github.com/users/octocat/repos"",
                    ""events_url"": ""https://api.github.com/users/octocat/events{/privacy}"",
                    ""received_events_url"": ""https://api.github.com/users/octocat/received_events"",
                    ""type"": ""User"",
                    ""site_admin"": false
                  },
                  ""name"": ""Hello-World"",
                  ""full_name"": ""octocat/Hello-World"",
                  ""description"": ""This your first repo!"",
                  ""private"": false,
                  ""fork"": true,
                  ""url"": ""https://api.github.com/repos/octocat/Hello-World"",
                  ""html_url"": ""https://github.com/octocat/Hello-World"",
                  ""archive_url"": ""http://api.github.com/repos/octocat/Hello-World/{archive_format}{/ref}"",
                  ""assignees_url"": ""http://api.github.com/repos/octocat/Hello-World/assignees{/user}"",
                  ""blobs_url"": ""http://api.github.com/repos/octocat/Hello-World/git/blobs{/sha}"",
                  ""branches_url"": ""http://api.github.com/repos/octocat/Hello-World/branches{/branch}"",
                  ""clone_url"": ""https://github.com/octocat/Hello-World.git"",
                  ""collaborators_url"": ""http://api.github.com/repos/octocat/Hello-World/collaborators{/collaborator}"",
                  ""comments_url"": ""http://api.github.com/repos/octocat/Hello-World/comments{/number}"",
                  ""commits_url"": ""http://api.github.com/repos/octocat/Hello-World/commits{/sha}"",
                  ""compare_url"": ""http://api.github.com/repos/octocat/Hello-World/compare/{base}...{head}"",
                  ""contents_url"": ""http://api.github.com/repos/octocat/Hello-World/contents/{+path}"",
                  ""contributors_url"": ""http://api.github.com/repos/octocat/Hello-World/contributors"",
                  ""deployments_url"": ""http://api.github.com/repos/octocat/Hello-World/deployments"",
                  ""downloads_url"": ""http://api.github.com/repos/octocat/Hello-World/downloads"",
                  ""events_url"": ""http://api.github.com/repos/octocat/Hello-World/events"",
                  ""forks_url"": ""http://api.github.com/repos/octocat/Hello-World/forks"",
                  ""git_commits_url"": ""http://api.github.com/repos/octocat/Hello-World/git/commits{/sha}"",
                  ""git_refs_url"": ""http://api.github.com/repos/octocat/Hello-World/git/refs{/sha}"",
                  ""git_tags_url"": ""http://api.github.com/repos/octocat/Hello-World/git/tags{/sha}"",
                  ""git_url"": ""git:github.com/octocat/Hello-World.git"",
                  ""hooks_url"": ""http://api.github.com/repos/octocat/Hello-World/hooks"",
                  ""issue_comment_url"": ""http://api.github.com/repos/octocat/Hello-World/issues/comments{/number}"",
                  ""issue_events_url"": ""http://api.github.com/repos/octocat/Hello-World/issues/events{/number}"",
                  ""issues_url"": ""http://api.github.com/repos/octocat/Hello-World/issues{/number}"",
                  ""keys_url"": ""http://api.github.com/repos/octocat/Hello-World/keys{/key_id}"",
                  ""labels_url"": ""http://api.github.com/repos/octocat/Hello-World/labels{/name}"",
                  ""languages_url"": ""http://api.github.com/repos/octocat/Hello-World/languages"",
                  ""merges_url"": ""http://api.github.com/repos/octocat/Hello-World/merges"",
                  ""milestones_url"": ""http://api.github.com/repos/octocat/Hello-World/milestones{/number}"",
                  ""mirror_url"": ""git:git.example.com/octocat/Hello-World"",
                  ""notifications_url"": ""http://api.github.com/repos/octocat/Hello-World/notifications{?since, all, participating}"",
                  ""pulls_url"": ""http://api.github.com/repos/octocat/Hello-World/pulls{/number}"",
                  ""releases_url"": ""http://api.github.com/repos/octocat/Hello-World/releases{/id}"",
                  ""ssh_url"": ""git@github.com:octocat/Hello-World.git"",
                  ""stargazers_url"": ""http://api.github.com/repos/octocat/Hello-World/stargazers"",
                  ""statuses_url"": ""http://api.github.com/repos/octocat/Hello-World/statuses/{sha}"",
                  ""subscribers_url"": ""http://api.github.com/repos/octocat/Hello-World/subscribers"",
                  ""subscription_url"": ""http://api.github.com/repos/octocat/Hello-World/subscription"",
                  ""svn_url"": ""https://svn.github.com/octocat/Hello-World"",
                  ""tags_url"": ""http://api.github.com/repos/octocat/Hello-World/tags"",
                  ""teams_url"": ""http://api.github.com/repos/octocat/Hello-World/teams"",
                  ""trees_url"": ""http://api.github.com/repos/octocat/Hello-World/git/trees{/sha}"",
                  ""homepage"": ""https://github.com"",
                  ""language"": null,
                  ""forks_count"": 9,
                  ""stargazers_count"": 80,
                  ""watchers_count"": 80,
                  ""size"": 108,
                  ""default_branch"": ""main"",
                  ""open_issues_count"": 0,
                  ""has_issues"": true,
                  ""has_wiki"": true,
                  ""has_pages"": false,
                  ""has_downloads"": true,
                  ""pushed_at"": ""2011-01-26T19:06:43Z"",
                  ""created_at"": ""2011-01-26T19:01:12Z"",
                  ""updated_at"": ""2011-01-26T19:14:43Z"",
                  ""permissions"": {
                    ""admin"": false,
                    ""push"": false,
                    ""pull"": true
                  }
                }
              ]
            }";

        [Fact]
        public void CanBeDeserialized()
        {
            var serializer = new SimpleJsonSerializer();

            var _migration = serializer.Deserialize<Migration>(migrationJson);

            Assert.Equal(79, _migration.Id);
            Assert.Equal("0b989ba4-242f-11e5-81e1-c7b6966d2516", _migration.Guid);
            Assert.Single(_migration.Repositories);
            Assert.Equal(1296269, _migration.Repositories[0].Id);
            Assert.Equal(Migration.MigrationState.Pending, _migration.State);
        }
    }

    public class StartMigrationTests
    {
        const string migrationRequestJson = @"
            {
              ""repositories"": [
                ""octocat/Hello-World""
              ],
              ""lock_repositories"": true
            }";

        private static readonly StartMigrationRequest migrationRequest = new StartMigrationRequest(
            new List<string>
            {
                "octocat/Hello-World"
            },
            true,
            false);

        [Fact]
        public void CanBeDeserialized()
        {
            var serializer = new SimpleJsonSerializer();

            var _migrationReuqest = serializer.Deserialize<StartMigrationRequest>(migrationRequestJson);

            Assert.Equal("octocat/Hello-World", _migrationReuqest.Repositories[0]);
            Assert.Single(_migrationReuqest.Repositories);
            Assert.True(_migrationReuqest.LockRepositories);
        }
    }
}
