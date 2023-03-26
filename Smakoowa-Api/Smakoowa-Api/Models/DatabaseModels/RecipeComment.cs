﻿namespace Smakoowa_Api.Models.DatabaseModels
{
    public class RecipeComment : Updatable, IDbKey, ILikeable
    {
        public int Id { get; set; }
        public string CommentContent { get; set; }

        public int RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }

        public virtual List<RecipeCommentLike>? Likes { get; set; }
        public virtual List<CommentReply>? CommentReplies { get; set; }
    }
}
