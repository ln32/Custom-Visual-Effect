# Custom-Visual-Effect

# Table of Contents
- [[1] CustomVoronoi](#1-CustomVoronoi)
- [[2] PopGainEffect](#2-PopGainEffect)
- [[3] FogEffect_SceneChange](#3-FogEffect_SceneChange)
- [[4] CustomFire](#4-CustomFire)
- [[0] Acknowledgement](#0-Acknowledgement)


# [1] CustomVoronoi

  배경 : 게임의 광원 효과를 내려 원형 sprite로 빛을 구현하니 너무 인위적인 감이 있어 카툰적 표현으로 광원 구현을 해보려 함

  ![image](https://github.com/ln32/CustomVoronoi/assets/94381505/84f5f329-117a-42ed-807d-51bbd8da9c8b)
  
  
  hlsl code - raw voronoi data 를 Stained glass 로 전환 
  
  
  ![image](https://github.com/ln32/CustomVoronoi/assets/94381505/b92a2b1f-a384-4e94-a966-2593f3d58b8d)
  
  Stained glass 전후비교



# [2] PopGainEffect

  ![myCoin](https://github.com/ln32/Custom-Visual-Effect/assets/94381505/1127a360-a2a9-45fa-88b8-09d716342a9e)

  인상깊던 포인트. 
  
    어려웠던 구현을 2가지 개별구현으로 하니 쉽게 구현이 되던 재밌던 경험
    
    ( 점을 중심으로 방사 후 모이는 이펙트, 시작점에서 목표점으로 등가속이동 하는 코드)



# [3] FogEffect_SceneChange

  구현 배경 : 게임의 씬 이동간에, 화면을 검게 변환시킬 중간 단계를 구현하는 쉐이더가 필요함을 느낌
  
  ![Animation3](https://github.com/ln32/Custom-Visual-Effect/assets/94381505/afb3eaae-9999-48f8-9b4e-856b34105847)
  
  개발하며 인상깊은 포인트) 애매하면 여러 효과를 겹치고 유효 영역을 계산하자



# [4] myCustomFire

  ![fireGif_1](https://github.com/ln32/Custom-Visual-Effect/assets/94381505/02bd3d2d-2689-4e54-bab1-0a5377a96bc3)
  
  ![fireGif_2](https://github.com/ln32/Custom-Visual-Effect/assets/94381505/42455cb9-1802-46e0-855b-e2eda24c947d)
  
  
  UV 왜곡을 통한 불꽃 일렁임 구현과 해당 영역에 알파값을 1이상으로 할당한 후, 포스트프로세싱을 통해 불꽃 쉐이더를 구현. 
  
  
  ![image](https://github.com/ln32/Custom-Visual-Effect/assets/94381505/86fe7ccc-99f5-41fc-9d78-d844e61df99d)
  
  위는 포스트 프로세싱이 없을 때의 출력





# [0] Acknowledgement

- (https://github.com/dev-ujin/awesome-readme-template/blob/master/res-readme/README-KO.md#features)
