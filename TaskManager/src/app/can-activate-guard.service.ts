import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router } from '@angular/router';
import { LoginService } from './login.service';

@Injectable({
  providedIn: 'root'
})
export class CanActivateGuardService implements CanActivate {

  constructor(private loginService:LoginService,private router:Router) { }

  canActivate(route:ActivatedRouteSnapshot):boolean
  {
    console.log(this.router.url);
    if(this.loginService.isAuthenticated()){
      return true;
    }
    else{
      this.router.navigate(["login"]);
      return false; 
    }
  }
}
