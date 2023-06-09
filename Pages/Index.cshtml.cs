﻿using Entity;
using Lasmart.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lasmart.Pages;

[IgnoreAntiforgeryToken]
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly RepositoryManager _repoManager;
    [BindProperty]
    public Point Point { get; set; }
    public IndexModel(ILogger<IndexModel> logger, RepositoryManager manager)
    {
        _logger = logger;
        _repoManager = manager;
    }

    public List<Point>? Points;

    public void OnGet()
    {
        Points = _repoManager.Points.GetAll().ToList();
    }

    public IActionResult OnPost()
    {
        System.Console.WriteLine(Point.Comments[0] ?? "null");
        _repoManager.Points.CreateAsync(Point);
        _repoManager.Save();
        return RedirectToPage();
    }
}
