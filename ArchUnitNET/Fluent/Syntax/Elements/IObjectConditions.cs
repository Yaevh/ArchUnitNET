﻿using System;
using System.Collections.Generic;
using ArchUnitNET.Domain;

namespace ArchUnitNET.Fluent.Syntax.Elements
{
    public interface IObjectConditions<out TReturnType>
    {
        TReturnType Exist();
        TReturnType Be(string pattern, bool useRegularExpressions = false);
        TReturnType Be(IEnumerable<string> patterns, bool useRegularExpressions = false);
        TReturnType Be(ICanBeAnalyzed firstObject, params ICanBeAnalyzed[] moreObjects);
        TReturnType Be(IEnumerable<ICanBeAnalyzed> objects);
        TReturnType Be(IObjectProvider<ICanBeAnalyzed> objects);
        TReturnType DependOnAny(string pattern, bool useRegularExpressions = false);
        TReturnType DependOnAny(IEnumerable<string> patterns, bool useRegularExpressions = false);
        TReturnType DependOnAny(IType firstType, params IType[] moreTypes);
        TReturnType DependOnAny(Type firstType, params Type[] moreTypes);
        TReturnType DependOnAny(IObjectProvider<IType> types);
        TReturnType DependOnAny(IEnumerable<IType> types);
        TReturnType DependOnAny(IEnumerable<Type> types);
        TReturnType OnlyDependOn(string pattern, bool useRegularExpressions = false);
        TReturnType OnlyDependOn(IEnumerable<string> patterns, bool useRegularExpressions = false);
        TReturnType OnlyDependOn(IType firstType, params IType[] moreTypes);
        TReturnType OnlyDependOn(Type firstType, params Type[] moreTypes);
        TReturnType OnlyDependOn(IObjectProvider<IType> types);
        TReturnType OnlyDependOn(IEnumerable<IType> types);
        TReturnType OnlyDependOn(IEnumerable<Type> types);
        TReturnType HaveName(string name);
        TReturnType HaveNameMatching(string pattern);
        TReturnType HaveFullName(string fullname);
        TReturnType HaveFullNameMatching(string pattern);
        TReturnType HaveNameStartingWith(string pattern);
        TReturnType HaveNameEndingWith(string pattern);
        TReturnType HaveNameContaining(string pattern);
        TReturnType HaveFullNameContaining(string pattern);
        TReturnType BePrivate();
        TReturnType BePublic();
        TReturnType BeProtected();
        TReturnType BeInternal();
        TReturnType BeProtectedInternal();
        TReturnType BePrivateProtected();


        //Negations


        TReturnType NotExist();
        TReturnType NotBe(string pattern, bool useRegularExpressions = false);
        TReturnType NotBe(IEnumerable<string> patterns, bool useRegularExpressions = false);
        TReturnType NotBe(ICanBeAnalyzed firstObject, params ICanBeAnalyzed[] moreObjects);
        TReturnType NotBe(IEnumerable<ICanBeAnalyzed> objects);
        TReturnType NotBe(IObjectProvider<ICanBeAnalyzed> objects);
        TReturnType NotDependOnAny(string pattern, bool useRegularExpressions = false);
        TReturnType NotDependOnAny(IEnumerable<string> patterns, bool useRegularExpressions = false);
        TReturnType NotDependOnAny(IType firstType, params IType[] moreTypes);
        TReturnType NotDependOnAny(Type firstType, params Type[] moreTypes);
        TReturnType NotDependOnAny(IObjectProvider<IType> types);
        TReturnType NotDependOnAny(IEnumerable<IType> types);
        TReturnType NotDependOnAny(IEnumerable<Type> types);
        TReturnType NotHaveName(string name);
        TReturnType NotHaveNameMatching(string pattern);
        TReturnType NotHaveFullName(string fullname);
        TReturnType NotHaveFullNameMatching(string pattern);
        TReturnType NotHaveNameStartingWith(string pattern);
        TReturnType NotHaveNameEndingWith(string pattern);
        TReturnType NotHaveNameContaining(string pattern);
        TReturnType NotHaveFullNameContaining(string pattern);
        TReturnType NotBePrivate();
        TReturnType NotBePublic();
        TReturnType NotBeProtected();
        TReturnType NotBeInternal();
        TReturnType NotBeProtectedInternal();
        TReturnType NotBePrivateProtected();
    }
}