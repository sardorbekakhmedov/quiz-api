namespace Quiz.CSharp.Api.Services.Abstractions;

using Quiz.CSharp.Api.Contracts;
using Quiz.CSharp.Data.Models;
using Quiz.Shared.Common;

public interface IQuestionService
{
    Task<PaginatedResult<QuestionResponse>> GetQuestionsByCollectionAsync(
        int collectionId,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default);
    Task<List<QuestionResponse>> GetPreviewQuestionsAsync(int collectionId, CancellationToken cancellationToken = default);
    Task<Result<CreateQuestionResponse>> CreateQuestionAsync(CreateQuestionModel model, CancellationToken cancellationToken = default);

    Task<Result<UpdateQuestionResponse>> UpdateQuestionAsync(
        int collectionId,
        UpdateQuestionModel model,
        CancellationToken cancellationToken);
} 