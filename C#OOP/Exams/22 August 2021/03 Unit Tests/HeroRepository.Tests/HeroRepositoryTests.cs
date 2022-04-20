using System;
using NUnit.Framework;

[TestFixture]
public class HeroRepositoryTests
{
    private HeroRepository heroRepo;
    private Hero hero;

    [SetUp]
    public void Setup()
    {
        heroRepo = new HeroRepository();
        hero = new Hero("sTiLLFree", 100);
    }
    
    // 1
    [Test]
   public void MustAddHeroToCollection()
    {
        heroRepo.Create(hero);
        Assert.IsTrue(heroRepo.Heroes.Count == 1);
    }
    
    // 2
    [Test]
    public void MustThrowArgNullExceptionForNullName()
    {
        hero = null;
        Assert.Throws<ArgumentNullException>(() => heroRepo.Create(hero));
    }
    
    // 3
    [Test]
    public void MustThrowErrorForExistingHero()
    {
        heroRepo.Create(hero);
        var _hero = new Hero("sTiLLFree", 100);

        Assert.Throws<InvalidOperationException>(() => heroRepo.Create(_hero));
    }
    
    // 4
    [Test]
    public void MMustReturnCorrectDataForHero()
    {
        heroRepo.Create(hero);
       var result = heroRepo.GetHero("sTiLLFree");
        Assert.AreEqual(hero, result);
    }
    
    // 5
    [Test]
    public void MustRemoveHero()
    {
        heroRepo.Create(hero);
        heroRepo.Remove("sTiLLFree");
        Assert.IsTrue(heroRepo.Heroes.Count == 0);
    }
    
    // 6
    [Test]
    public void MustReturnHighestLevelCorrectly()
    {
        var minLevel = new Hero("min", 1);
        var middleLevel = new Hero("middle", 50);
        
        heroRepo.Create(hero);
        heroRepo.Create(minLevel);
        heroRepo.Create(middleLevel);

        var result = heroRepo.GetHeroWithHighestLevel();
        bool isTheSame = result == hero;
        Assert.IsTrue(isTheSame);
    }
}
