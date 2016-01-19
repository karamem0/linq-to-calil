﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karamem0.LinqToCalil {

    /// <summary>
    /// カーリル API をクエリするための拡張メソッドを定義します。
    /// </summary>
    public static class Calil {

        /// <summary>
        /// 図書館検索のコンテキストを返します。
        /// </summary>
        /// <param name="appKey">アプリケーション キーを示す <see cref="System.String"/>。</param>
        /// <returns>作成された <see cref="Karamem0.LinqToCalil.ICalilQueryableContext{TParam, TResult}"/>。</returns>
        public static CalilLibraryContext GetLibrary(string appKey) {
            return new CalilLibraryContext(appKey);
        }

        /// <summary>
        /// 図書館検索のコンテキストを返します。
        /// </summary>
        /// <param name="appKey">アプリケーション キーを示す <see cref="System.String"/>。</param>
        /// <param name="param">検索フィルタを示す <see cref="Karamem0.LinqToCalil.CalilLibraryParameter"/>。</param>
        /// <returns>作成された <see cref="Karamem0.LinqToCalil.ICalilQueryableContext{TParam, TResult}"/>。</returns>
        public static CalilLibraryContext GetLibrary(string appKey, CalilLibraryParameter param) {
            return new CalilLibraryContext(appKey, param.CreateExpression());
        }

        /// <summary>
        /// 蔵書検索のコンテキストを返します。
        /// </summary>
        /// <param name="appKey">アプリケーション キーを示す <see cref="System.String"/>。</param>
        /// <returns>作成された <see cref="Karamem0.LinqToCalil.ICalilPollingContext{TParam, TResult}"/>。</returns>
        public static ICalilPollingContext<CalilCheckParameter, CalilCheckResult>
            GetCheck(string appKey) {
            return new CalilCheckContext(appKey);
        }

        /// <summary>
        /// 蔵書検索のコンテキストを返します。
        /// </summary>
        /// <param name="appKey">アプリケーション キーを示す <see cref="System.String"/>。</param>
        /// <param name="param">検索フィルタを示す <see cref="Karamem0.LinqToCalil.CalilCheckParameter"/>。</param>
        /// <returns>作成された <see cref="Karamem0.LinqToCalil.ICalilPollingContext{TParam, TResult}"/>。</returns>
        public static ICalilPollingContext<CalilCheckParameter, CalilCheckResult>
            GetCheck(string appKey, CalilCheckParameter param) {
            return new CalilCheckContext(appKey, param.CreateExpression());
        }

        /// <summary>
        /// 市町村リストのコンテキストを返します。
        /// </summary>
        /// <returns></returns>
        public static CalilCityListContext GetCityList() {
            return new CalilCityListContext();
        }

    }

}
