using System;
using System.Collections.Generic;
using StateManagement.Models;

namespace StateManagement.Services;

public class BurgetStateService
{
    public List<Ingredient> lstFood = new List<Ingredient>(){
    new Ingredient { name = "salad" , unitPrice = 1000, quantity = 0},
    new Ingredient { name = "cheese" , unitPrice = 2000, quantity = 0},
    new Ingredient { name = "beef" , unitPrice = 3000, quantity = 0}
   };
    public void AddIngredient(Ingredient Aquantity)
    {
        var item = lstFood.Find(x => x.name == Aquantity.name);
        item.quantity += 1;
        SetStateHasChange();
    }
    public void RemoveIngredient(Ingredient Dquantity)
    {
        var item = lstFood.Find(x => x.name == Dquantity.name);
        if(item.quantity == 0){

        }
        else{
        item.quantity -= 1;
        }
        SetStateHasChange();
    }
    public double TotalPrice(Ingredient total)
    {
        var item = lstFood.Find(x => x.name == total.name);
        return item.unitPrice * item.quantity;
    }
    public event Action OnChange;
    private void SetStateHasChange() => OnChange?.Invoke();

}