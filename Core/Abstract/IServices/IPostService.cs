using Core.Concrete.DTTOs;
using System.Collections.Generic;

namespace Core.Abstract.IServices
{
    public interface IPostService
    {
        IEnumerable<PostListItemDto> GetPostList(string autherId);
        PostDetailDto GetPostDetail(int id);
        UpdatePostDto GetPostEdit(int id);
        void CreatePost(NewPostDto newPost);
        void UpdatePost(UpdatePostDto updatedPost);
        void DeletePost(int id, string authorId);
    }
}
