using Core.Concrete.DTTOs;
using System.Collections.Generic;

namespace Core.Abstract.IServices
{
    public interface IPostService
    {
        IEnumerable<PostListItemDto> GetPostList();
        PostDetailDto GetPostDetail(int id);

        void CreatePost(NewPostDto newPost);
        void UpdatePost(UpdatePostDto updatedPost);
        void DeletePost(int id, string authorId);
    }
}
