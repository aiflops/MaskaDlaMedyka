﻿using MDMProject.Models;
using MDMProject.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace MDMProject.Mappers
{
    public static class UserListMapper
    {
        public static IEnumerable<UserListViewModel> ToUserListViewModels(this IEnumerable<User> collection, HashSet<int> allCoordinatorIds, HashSet<int> allAdminIds)
        {
            var result = collection.Select(x => x.ToUserListViewModel(allCoordinatorIds, allAdminIds));
            return result;
        }

        public static UserListViewModel ToUserListViewModel(this User user, HashSet<int> allCoordinatorIds, HashSet<int> allAdminIds)
        {
            var viewModel = new UserListViewModel();
            viewModel.Id = user.Id;
            viewModel.UserType = user.UserType;
            viewModel.Email = user.Email;
            viewModel.PhoneNumber = user.PhoneNumber;
            viewModel.AdditionalComment = user.AdditionalComment;
            
            viewModel.IndividualName = user.IndividualName;
            viewModel.CompanyName = user.CompanyName;
            viewModel.ContactPersonName = user.ContactPersonName;
            
            viewModel.CoordinatorName = user.Coordinator?.FullUserName; // if no coordinator selected
            viewModel.OtherCoordinatorDetails = user.OtherCoordinatorDetails; // if no coordinator selected
            
            viewModel.City = user.Address?.City;
            viewModel.StreetName = user.Address?.StreetName;
            viewModel.HouseNumber = user.Address?.HouseNumber;
            viewModel.FlatNumber = user.Address?.FlatNumber;
            viewModel.PostalCode = user.Address?.PostalCode;

            viewModel.ProfileFinishedDate = user.ProfileFinishedDate;
            viewModel.ApprovedBy = user.ApprovedBy?.FullUserName;
            viewModel.ApprovedDate = user.ApprovedDate;

            viewModel.IsCoordinator = allCoordinatorIds.Contains(user.Id);
            viewModel.IsAdmin = allAdminIds.Contains(user.Id);

            return viewModel;
        }
    }
}