WITH CountryCTE(CountryId, Name)
AS
(
	SELECT	4	,'Afghanistan' UNION ALL
	SELECT	8	,'Albania' UNION ALL
	SELECT	10	,'Antarctica' UNION ALL
	SELECT	12	,'Algeria' UNION ALL
	SELECT	16	,'American Samoa' UNION ALL
	SELECT	20	,'Andorra' UNION ALL
	SELECT	24	,'Angola' UNION ALL
	SELECT	28	,'Antigua and Barbuda' UNION ALL
	SELECT	31	,'Azerbaijan' UNION ALL
	SELECT	32	,'Argentina' UNION ALL
	SELECT	36	,'Australia' UNION ALL
	SELECT	40	,'Austria' UNION ALL
	SELECT	44	,'Bahamas' UNION ALL
	SELECT	48	,'Bahrain' UNION ALL
	SELECT	50	,'Bangladesh' UNION ALL
	SELECT	51	,'Armenia' UNION ALL
	SELECT	52	,'Barbados' UNION ALL
	SELECT	56	,'Belgium' UNION ALL
	SELECT	60	,'Bermuda' UNION ALL
	SELECT	64	,'Bhutan' UNION ALL
	SELECT	68	,'Bolivia' UNION ALL
	SELECT	70	,'Bosnia and Herzegovina' UNION ALL
	SELECT	72	,'Botswana' UNION ALL
	SELECT	74	,'Bouvet Island' UNION ALL
	SELECT	76	,'Brazil' UNION ALL
	SELECT	84	,'Belize' UNION ALL
	SELECT	86	,'British Indian Ocean Territory' UNION ALL
	SELECT	90	,'Solomon Islands' UNION ALL
	SELECT	92	,'British Virgin Islands' UNION ALL
	SELECT	96	,'Brunei Darussalam' UNION ALL
	SELECT	100	,'Bulgaria' UNION ALL
	SELECT	104	,'Myanmar' UNION ALL
	SELECT	108	,'Burundi' UNION ALL
	SELECT	112	,'Belarus' UNION ALL
	SELECT	116	,'Cambodia' UNION ALL
	SELECT	120	,'Cameroon' UNION ALL
	SELECT	124	,'Canada' UNION ALL
	SELECT	132	,'Cape Verde' UNION ALL
	SELECT	136	,'Cayman Islands' UNION ALL
	SELECT	140	,'Central African Republic' UNION ALL
	SELECT	144	,'Sri Lanka' UNION ALL
	SELECT	148	,'Chad' UNION ALL
	SELECT	152	,'Chile' UNION ALL
	SELECT	156	,'China' UNION ALL
	SELECT	158	,'Taiwan, Province of China' UNION ALL
	SELECT	162	,'Christmas Island' UNION ALL
	SELECT	166	,'Cocos (Keeling) Islands' UNION ALL
	SELECT	170	,'Colombia' UNION ALL
	SELECT	174	,'Comoros' UNION ALL
	SELECT	175	,'Mayotte' UNION ALL
	SELECT	178	,'Congo' UNION ALL
	SELECT	180	,'Democratic Republic of the Congo' UNION ALL
	SELECT	184	,'Cook Islands' UNION ALL
	SELECT	188	,'Costa Rica' UNION ALL
	SELECT	191	,'Croatia' UNION ALL
	SELECT	192	,'Cuba' UNION ALL
	SELECT	196	,'Cyprus' UNION ALL
	SELECT	203	,'Czech Republic' UNION ALL
	SELECT	204	,'Benin' UNION ALL
	SELECT	208	,'Denmark' UNION ALL
	SELECT	212	,'Dominica' UNION ALL
	SELECT	214	,'Dominican Republic' UNION ALL
	SELECT	218	,'Ecuador' UNION ALL
	SELECT	222	,'El Salvador' UNION ALL
	SELECT	226	,'Equatorial Guinea' UNION ALL
	SELECT	231	,'Ethiopia' UNION ALL
	SELECT	232	,'Eritrea' UNION ALL
	SELECT	233	,'Estonia' UNION ALL
	SELECT	234	,'Faroe Islands' UNION ALL
	SELECT	238	,'Falkland Islands (Malvinas)' UNION ALL
	SELECT	239	,'South Georgia and the South Sandwich Islands' UNION ALL
	SELECT	242	,'Fiji' UNION ALL
	SELECT	246	,'Finland' UNION ALL
	SELECT	250	,'France' UNION ALL
	SELECT	254	,'French Guiana' UNION ALL
	SELECT	258	,'French Polynesia' UNION ALL
	SELECT	260	,'French Southern Territories' UNION ALL
	SELECT	262	,'Djibouti' UNION ALL
	SELECT	266	,'Gabon' UNION ALL
	SELECT	268	,'Georgia' UNION ALL
	SELECT	270	,'Gambia' UNION ALL
	SELECT	275	,'Palestine, State of' UNION ALL
	SELECT	276	,'Germany' UNION ALL
	SELECT	288	,'Ghana' UNION ALL
	SELECT	292	,'Gibraltar' UNION ALL
	SELECT	296	,'Kiribati' UNION ALL
	SELECT	300	,'Greece' UNION ALL
	SELECT	304	,'Greenland' UNION ALL
	SELECT	308	,'Grenada' UNION ALL
	SELECT	312	,'Guadeloupe' UNION ALL
	SELECT	316	,'Guam' UNION ALL
	SELECT	320	,'Guatemala' UNION ALL
	SELECT	324	,'Guinea' UNION ALL
	SELECT	328	,'Guyana' UNION ALL
	SELECT	332	,'Haiti' UNION ALL
	SELECT	334	,'Heard Island and McDonald Mcdonald Islands' UNION ALL
	SELECT	336	,'Holy See (Vatican City State)' UNION ALL
	SELECT	340	,'Honduras' UNION ALL
	SELECT	344	,'Hong Kong' UNION ALL
	SELECT	348	,'Hungary' UNION ALL
	SELECT	352	,'Iceland' UNION ALL
	SELECT	356	,'India' UNION ALL
	SELECT	360	,'Indonesia' UNION ALL
	SELECT	364	,'Iran, Islamic Republic of' UNION ALL
	SELECT	368	,'Iraq' UNION ALL
	SELECT	372	,'Ireland' UNION ALL
	SELECT	376	,'Israel' UNION ALL
	SELECT	380	,'Italy' UNION ALL
	SELECT	384	,'Cote d''Ivoire' UNION ALL
	SELECT	388	,'Jamaica' UNION ALL
	SELECT	392	,'Japan' UNION ALL
	SELECT	398	,'Kazakhstan' UNION ALL
	SELECT	400	,'Jordan' UNION ALL
	SELECT	404	,'Kenya' UNION ALL
	SELECT	408	,'Korea, Democratic People''s Republic of' UNION ALL
	SELECT	410	,'Korea, Republic of' UNION ALL
	SELECT	414	,'Kuwait' UNION ALL
	SELECT	417	,'Kyrgyzstan' UNION ALL
	SELECT	418	,'Lao People''s Democratic Republic' UNION ALL
	SELECT	422	,'Lebanon' UNION ALL
	SELECT	426	,'Lesotho' UNION ALL
	SELECT	428	,'Latvia' UNION ALL
	SELECT	430	,'Liberia' UNION ALL
	SELECT	434	,'Libya' UNION ALL
	SELECT	438	,'Liechtenstein' UNION ALL
	SELECT	440	,'Lithuania' UNION ALL
	SELECT	442	,'Luxembourg' UNION ALL
	SELECT	446	,'Macao' UNION ALL
	SELECT	450	,'Madagascar' UNION ALL
	SELECT	454	,'Malawi' UNION ALL
	SELECT	458	,'Malaysia' UNION ALL
	SELECT	462	,'Maldives' UNION ALL
	SELECT	466	,'Mali' UNION ALL
	SELECT	470	,'Malta' UNION ALL
	SELECT	474	,'Martinique' UNION ALL
	SELECT	478	,'Mauritania' UNION ALL
	SELECT	480	,'Mauritius' UNION ALL
	SELECT	484	,'Mexico' UNION ALL
	SELECT	492	,'Monaco' UNION ALL
	SELECT	496	,'Mongolia' UNION ALL
	SELECT	498	,'Moldova, Republic of' UNION ALL
	SELECT	499	,'Montenegro' UNION ALL
	SELECT	500	,'Montserrat' UNION ALL
	SELECT	504	,'Morocco' UNION ALL
	SELECT	508	,'Mozambique' UNION ALL
	SELECT	512	,'Oman' UNION ALL
	SELECT	516	,'Namibia' UNION ALL
	SELECT	520	,'Nauru' UNION ALL
	SELECT	524	,'Nepal' UNION ALL
	SELECT	528	,'Netherlands' UNION ALL
	SELECT	531	,'Curacao' UNION ALL
	SELECT	533	,'Aruba' UNION ALL
	SELECT	534	,'Sint Maarten (Dutch part)' UNION ALL
	SELECT	535	,'Bonaire' UNION ALL
	SELECT	540	,'New Caledonia' UNION ALL
	SELECT	548	,'Vanuatu' UNION ALL
	SELECT	554	,'New Zealand' UNION ALL
	SELECT	558	,'Nicaragua' UNION ALL
	SELECT	562	,'Niger' UNION ALL
	SELECT	566	,'Nigeria' UNION ALL
	SELECT	570	,'Niue' UNION ALL
	SELECT	574	,'Norfolk Island' UNION ALL
	SELECT	578	,'Norway' UNION ALL
	SELECT	580	,'Northern Mariana Islands' UNION ALL
	SELECT	581	,'United States Minor Outlying Islands' UNION ALL
	SELECT	583	,'Micronesia, Federated States of' UNION ALL
	SELECT	584	,'Marshall Islands' UNION ALL
	SELECT	585	,'Palau' UNION ALL
	SELECT	586	,'Pakistan' UNION ALL
	SELECT	591	,'Panama' UNION ALL
	SELECT	598	,'Papua New Guinea' UNION ALL
	SELECT	600	,'Paraguay' UNION ALL
	SELECT	604	,'Peru' UNION ALL
	SELECT	608	,'Philippines' UNION ALL
	SELECT	612	,'Pitcairn' UNION ALL
	SELECT	616	,'Poland' UNION ALL
	SELECT	620	,'Portugal' UNION ALL
	SELECT	624	,'Guinea-Bissau' UNION ALL
	SELECT	626	,'Timor-Leste' UNION ALL
	SELECT	630	,'Puerto Rico' UNION ALL
	SELECT	634	,'Qatar' UNION ALL
	SELECT	638	,'Reunion' UNION ALL
	SELECT	642	,'Romania' UNION ALL
	SELECT	643	,'Russian Federation' UNION ALL
	SELECT	646	,'Rwanda' UNION ALL
	SELECT	652	,'Saint Barthelemy' UNION ALL
	SELECT	654	,'Saint Helena' UNION ALL
	SELECT	659	,'Saint Kitts and Nevis' UNION ALL
	SELECT	660	,'Anguilla' UNION ALL
	SELECT	662	,'Saint Lucia' UNION ALL
	SELECT	663	,'Saint Martin (French part)' UNION ALL
	SELECT	666	,'Saint Pierre and Miquelon' UNION ALL
	SELECT	670	,'Saint Vincent and the Grenadines' UNION ALL
	SELECT	674	,'San Marino' UNION ALL
	SELECT	678	,'Sao Tome and Principe' UNION ALL
	SELECT	682	,'Saudi Arabia' UNION ALL
	SELECT	686	,'Senegal' UNION ALL
	SELECT	688	,'Serbia' UNION ALL
	SELECT	690	,'Seychelles' UNION ALL
	SELECT	694	,'Sierra Leone' UNION ALL
	SELECT	702	,'Singapore' UNION ALL
	SELECT	703	,'Slovakia' UNION ALL
	SELECT	704	,'Viet Nam' UNION ALL
	SELECT	705	,'Slovenia' UNION ALL
	SELECT	706	,'Somalia' UNION ALL
	SELECT	710	,'South Africa' UNION ALL
	SELECT	716	,'Zimbabwe' UNION ALL
	SELECT	724	,'Spain' UNION ALL
	SELECT	728	,'South Sudan' UNION ALL
	SELECT	729	,'Sudan' UNION ALL
	SELECT	732	,'Western Sahara' UNION ALL
	SELECT	740	,'Suriname' UNION ALL
	SELECT	744	,'Svalbard and Jan Mayen' UNION ALL
	SELECT	748	,'Swaziland' UNION ALL
	SELECT	752	,'Sweden' UNION ALL
	SELECT	756	,'Switzerland' UNION ALL
	SELECT	760	,'Syrian Arab Republic' UNION ALL
	SELECT	762	,'Tajikistan' UNION ALL
	SELECT	764	,'Thailand' UNION ALL
	SELECT	768	,'Togo' UNION ALL
	SELECT	772	,'Tokelau' UNION ALL
	SELECT	776	,'Tonga' UNION ALL
	SELECT	780	,'Trinidad and Tobago' UNION ALL
	SELECT	784	,'United Arab Emirates' UNION ALL
	SELECT	788	,'Tunisia' UNION ALL
	SELECT	792	,'Turkey' UNION ALL
	SELECT	795	,'Turkmenistan' UNION ALL
	SELECT	796	,'Turks and Caicos Islands' UNION ALL
	SELECT	798	,'Tuvalu' UNION ALL
	SELECT	800	,'Uganda' UNION ALL
	SELECT	804	,'Ukraine' UNION ALL
	SELECT	807	,'Macedonia, the Former Yugoslav Republic of' UNION ALL
	SELECT	818	,'Egypt' UNION ALL
	SELECT	826	,'United Kingdom' UNION ALL
	SELECT	831	,'Guernsey' UNION ALL
	SELECT	832	,'Jersey' UNION ALL
	SELECT	833	,'Isle of Man' UNION ALL
	SELECT	834	,'United Republic of Tanzania' UNION ALL
	SELECT	840	,'United States' UNION ALL
	SELECT	850	,'US Virgin Islands' UNION ALL
	SELECT	854	,'Burkina Faso' UNION ALL
	SELECT	858	,'Uruguay' UNION ALL
	SELECT	860	,'Uzbekistan' UNION ALL
	SELECT	862	,'Venezuela' UNION ALL
	SELECT	876	,'Wallis and Futuna' UNION ALL
	SELECT	882	,'Samoa' UNION ALL
	SELECT	887	,'Yemen' UNION ALL
	SELECT	894	,'Zambia'
)

INSERT [dbo].[Country] (CountryId, Name)
SELECT CountryId, Name
FROM CountryCTE
WHERE NOT EXISTS (SELECT NULL as [empty] FROM [dbo].[Country] WHERE CountryId = CountryCTE.CountryId)
;