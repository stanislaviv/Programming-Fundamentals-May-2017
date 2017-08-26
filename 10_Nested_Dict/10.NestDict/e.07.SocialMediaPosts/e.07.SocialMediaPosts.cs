using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e._07.SocialMediaPosts
{
	class Program
	{
		static Dictionary<string, Dictionary<string, string>>
								postComments = new Dictionary<string, Dictionary<string, string>>();

		static Dictionary<string, int> postLikes = new Dictionary<string, int>();
		static Dictionary<string, int> postDisLikes = new Dictionary<string, int>();


		static void Main(string[] args)
		{

			string input = Console.ReadLine();

			while (input != "drop the media")
			{
				string[] inputTokens = input.Split(' ');

				string command = inputTokens[0];
				string postName = inputTokens[1];

				switch (command)
				{
					case "post":
						{
							CreatePost(postName);
							break;
						}
					case "like":
						{
							LikePost(postName);
							break;
						}

					case "dislike":
						{
							DislikePost(postName);
							break;
						}

					case "comment":
						{
							string commentatorName = inputTokens[2];
							string commentContent = string.Join(" ", inputTokens.Skip(3).ToArray());

							CommentPost(postName, commentatorName, commentContent);
							break;
						}


				}

				input = Console.ReadLine();
			}

			foreach (var postCommentData in postComments)
			{
				string postName = postCommentData.Key;
				int likes = postLikes[postName];
				int dislikes = postDisLikes[postName];
				Dictionary<string, string> commentsData = postCommentData.Value;

				Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}", postName, likes, dislikes);

				Console.WriteLine("Comments:");

				if (commentsData.Count == 0)
				{
					Console.WriteLine("None");
				}

				foreach (var commentData in commentsData)
				{
					string commentatorName = commentData.Key;
					string commentContent = commentData.Value;

					Console.WriteLine("*  {0}: {1}", commentatorName, commentContent);
				}
			}
		}

		private static void CreatePost(string postName)
		{
			postComments.Add(postName, new Dictionary<string, string>());
			postLikes.Add(postName, 0);
			postDisLikes.Add(postName, 0);

		}
		private static void LikePost(string postName)
		{
			postLikes[postName]++;
		}
		private static void DislikePost(string postName)
		{
			postDisLikes[postName]++;
		}
		private static void CommentPost(string postName, string comentatorName, string commentContent)
		{
			postComments[postName].Add(comentatorName, commentContent);
		}
	}

}


